<template>
  <div id="main">
      <div class="positive">
        
        <button>Vote</button>
        <h4>I love it 20</h4>
        <img src="../assets/pizza.png" alt="Pizza image"/>
      </div>
  </div>
</template>

<script>
export default {
    name: 'PostVotePizza'
}
</script>

<style scoped>
button{
    width: 60px;
    margin-left: 70px;
    padding: 10px;
    background: greenyellow;
    border: none;
    border-radius: 10px;
    cursor: pointer;
}
.positive {
  display: flex;
  flex-direction: column-reverse;
}
</style>