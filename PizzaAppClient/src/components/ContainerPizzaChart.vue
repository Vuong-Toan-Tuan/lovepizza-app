<template>
    <!--<ContainerPizzaChart />-->
    <div>
        <h1>aaaaaaaaa</h1>
        <h2>bbbbbbbb</h2>
        <div id="app">
            {{ info }}
        </div>
    </div>
    
</template>

<script>
    import axios from 'axios';
    export default {
        name: 'ContainerPizzaChart',
        methods: {
            async getAllData() {
                try {
                    const res = await axios.get('https://jsonplaceholder.typicode.com/todos/1')
                    console.log(res.data)
                } catch (error) {
                    console.log(error)
                }
            }
        },
        mounted() {
            this.getAllData()
        }
    }

</script>

<style scoped>

</style>