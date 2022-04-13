<template>
  <form @submit="addvote">
    <input type="text" v-model="title" />
    <input type="submit" value="Thêm" class="add-btn" />
  </form>
</template>

<script>
import { ref } from 'vue'

export default {
    name: 'TestPostVote',
    setup(props, context) {
        const title = ref('')
        const addvote = event => {
            event.preventDefault()
            const newItem = {
                // id: uuidv4(),
                title: title.value,
                completed: false
            }
            context.emit('add-todo', newItem)
            title.value = ''
        }
        return {
            title, addvote
        }
    }
    
}
</script>

<style>

</style>