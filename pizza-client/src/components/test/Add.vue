<template>
  <TestPostVote />
  <Item 
    v-for="a in datas"
    :key="a.id"
    :dataProps="a"
  />
</template>

<script>
import { ref } from 'vue'
import axios from 'axios'
import TestPostVote from './TestPostVote.vue'
import Item from './Item.vue'

export default {
    name: 'Add',
    components: {
        TestPostVote,
        Item
    },
    setup() {
        const datas = ref([])
        
        const getAll = async () => {
            try {
                const res = await axios.get(
                'https://jsonplaceholder.typicode.com/todos?_limit=5'
                )
                // console.log(res.data)
                datas.value = res.data
            } catch (error) {
                console.log(error)
            }
        }
        getAll()

        const addTodo = async newTodo => {
            try {
                const res = await axios.post(
                'https://jsonplaceholder.typicode.com/todos',
                newTodo
                )
                datas.value.push(res.data)
                // console.log(datas)
            } catch (error) {
                console.log(error)
            }
        }

        return {
            datas,
            addTodo
        }
    }
}
</script>

<style>

</style>