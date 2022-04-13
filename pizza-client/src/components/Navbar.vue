<template>
  <div>
    <div class="topnav">
      <router-link to="/">Love Pizza</router-link>
      <router-link to = "/Login">Logout</router-link>
      <router-link to = "/Login">Login</router-link>
    </div>
  </div>
</template>

<script>
export default {
    name: 'Header'
    
}
</script>

<style scoped>
  .topnav {
    background-color: rgb(235, 208, 208);
    overflow: hidden;
    height: 60px;
  }
  .topnav a {
  float: left;
  color: #292020;
  text-align: center;
  padding: 20px;
  text-decoration: none;
  font-size: 17px;
  }
  .topnav a:hover {
  background-color: rgb(49, 40, 40);
  color: rgb(212, 171, 171);
  }
  
</style>>