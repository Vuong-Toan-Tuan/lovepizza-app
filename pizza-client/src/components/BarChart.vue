<template>
  <div id="main">
    <Bar
      :chart-options="chartOptions"
      :chart-data="chartData"
      :chart-id="chartId"
      :dataset-id-key="datasetIdKey"
      :plugins="plugins"
      :css-classes="cssClasses"
      :styles="styles"
      :width="width"
      :height="height"
    />
  </div>
  
</template>

<script>
import axios from 'axios'
import { Bar } from 'vue-chartjs'
import { Chart as ChartJS, Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale } from 'chart.js'

ChartJS.register(Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale)

export default {
  name: 'BarChart',
  components: { Bar },
    props: {
    chartId: {
      type: String,
      default: 'bar-chart'
    },
    datasetIdKey: {
      type: String,
      default: 'label'
    },
    width: {
      type: Number,
      default: 400
    },
    height: {
      type: Number,
      default: 400
    },
    cssClasses: {
      default: '',
      type: String
    },
    styles: {
      type: Object,
      default: () => {}
    },
    plugins: {
      type: Object,
      default: () => {}
    }
  },
  data() {
    return {
      chartData: {
        labels: [ ],
        datasets: [ { data: [] } ]
      },
      chartOptions: {
        responsive: true
      }
    }
  },
  async created() {
    const a = await axios.get('https://localhost:44320/api/pizzavote')
    console.log(a.data)
    const id = []
    const value = []
    a.data.forEach(element => {
      id.push(element.id)
      value.push(element.value)
    });

    this.chartData = {
      labels: id,
      datasets: [ 
        { 
          label: 'Pizza Lovers',
          backgroundColor: '#f87979',
          data: value
        }
      ]
    }
  }
    
   
}
</script>
<style scoped>
  
  
</style>