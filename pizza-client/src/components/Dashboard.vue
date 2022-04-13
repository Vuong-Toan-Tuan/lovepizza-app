<template>
  <div>
    <Navbar />
    <Header />
    <PostVotePizza id="postvote" />
    <BarChart id="chart" />
  </div> 
</template>

<script>

import Navbar from './Navbar.vue'
import Header from './Header.vue'
import BarChart from './BarChart.vue'
import PostVotePizza from './PostVotePizza.vue'

export default {
  name: 'Dashboard',
  components: {
    Navbar,
    Header,
    BarChart,
    PostVotePizza
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 20px;
}
#chart {
    width: 500px;
    float: right;
  }
#a {
  display: flex;
}
#postvote {
  margin-left: 40%;
  padding-top: 40px;
  position: absolute;
  
}
</style>
