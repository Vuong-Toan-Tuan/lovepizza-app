<template>
    <div>
        <h2>Pizz App a</h2>
        <b-navbar toggleable="md" type="light" variant="light">
            <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
            <b-navbar-brand to="/">Love Pizza</b-navbar-brand>
            <b-collapse is-nav id="nav-collapse">
                <b-navbar-nav>
                    <b-nav-item href="#" @click.prevent="login" v-if="!user">Login</b-nav-item>
                    <b-nav-item href="#" @click.prevent="logout" v-else>Logout</b-nav-item>
                    <username v-if="user" :username="user.email"></username>
                </b-navbar-nav>
            </b-collapse>
        </b-navbar>
        
    </div>
</template>

<script>
    
    export default {
        name: 'Header'
    }
</script>

<style scoped>
    h2 {
        color: red;
        text-align: center;
    }
</style>