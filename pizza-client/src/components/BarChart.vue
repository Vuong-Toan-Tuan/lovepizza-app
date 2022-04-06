<template>
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
</template>

<script>
// import axios from 'axios'
import { Bar } from 'vue-chartjs'
import { Chart as ChartJS, Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale } from 'chart.js'

ChartJS.register(Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale)

export default {
  name: 'BarChart',
  components: { Bar },
    // setup() {
    //     const getAll = async () => {
    //         try{
    //             const a = await axios.get('https://localhost:44320/api/pizzavote')
    //             // a.forEach(element => {
    //             //     console.log(element)
    //             // });
    //             // console.log(a.data[1])
    //             // var listdata = JSON.parse(a.data[1]);
    //             var obj = (a.data[1]);
    //             console.log(obj.id)
    //             console.log(obj.value)
    //             console.log(obj.dateTime)
    //             // var nametest = obj.id

    //         } catch (error){
    //             console.log(error)
    //         }
    //     }
    //     getAll();
    // },
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
        labels: [ 'January', 'February', 'March' ],
        datasets: [ { data: [40, 20, 12] } ]
      },
      chartOptions: {
        responsive: true
      }
    }
  }
    
    // data() {
    //     // const abc = ['a']
    //     // // var nametest = getAll();
    //     const getAll = async () => {
    //         try{
    //             const a = await axios.get('https://localhost:44320/api/pizzavote')
    //             a.forEach(element => {
    //                 console.log(element)
    //             });
    //             // console.log(a.data[1])
    //             // var listdata = JSON.parse(a.data[1]);
    //             var obj = (a.data[1]);
    //             console.log(obj.id)
    //             console.log(obj.value)
    //             console.log(obj.dateTime)
                

    //         } catch (error){
    //             console.log(error)
    //         }
    //     }
    //     getAll();
        

    //     return {
            
    //         chartData: {
    //             labels: ['a','b','c' ],
    //             datasets: [ { data: [40, 20, 12] } ]
    //         },
    //         chartOptions: {
    //             responsive: true
    //         }
    //     },
        

    // }
}
</script>
