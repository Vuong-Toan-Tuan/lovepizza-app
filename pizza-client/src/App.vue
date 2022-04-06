<template>
  
  <Header />
  <Container />
  <BarChart />
</template>

<script>

import Header from './components/Header.vue'
import Container from './components/Container.vue'
import BarChart from './components/BarChart.vue'

export default {
  name: 'App',
  components: {
    Container: Container,
    Header: Header,
    BarChart: BarChart
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
  margin-top: 60px;
}
</style>
