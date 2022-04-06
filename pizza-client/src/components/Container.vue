<template>
  <div>
      <h2>container</h2>
  </div>
</template>

<script>
import axios from 'axios'


export default {
    setup() {
        const getAll = async () => {
            try{
                const a = await axios.get('https://localhost:44320/api/pizzavote')
                console.log(a.data)
            } catch (error){
                console.log(error)
            }
        }
        getAll();
    }
    
}
</script>

<style>

</style>