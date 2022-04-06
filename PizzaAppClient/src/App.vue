<template>
    <div id="app">
        <Home msg="Hello world!" />
        <Header />
        <ContainerPizzaChart />
    </div>
</template>

<script>
    //import Home from './components/Home.vue';
    import Header from './components/Header.vue';
    import ContainerPizzaChart from './components/ContainerPizzaChart.vue';

    export default {
        name: 'app',
        components: {
            Header: Header,
            ContainerPizzaChart: ContainerPizzaChart
        }
    };
</script>

<style>
</style>

