<template>
  <div>
    <h3>Login to Love Pizza app</h3>
    <form @submit.prevent="submit">
        <!-- <label for="email">Email: </label>
        <input type="text" v-model="email" name="email"/> -->
        <input type="text" v-model="username" placeholder="username"/><br>
        <input type="text" v-model="password" placeholder="password"/>
        <br><br>
        <button type="submit" @click="login">Login</button>
    </form>
  </div>
</template>

<script>
// import axios from 'axios'
// import {reactive} from 'vue'
// import {useRouter} from 'vue-router'
import {mapActions, mapGetters} from 'vuex'

export default {
    
    name: 'Login',
    // setup() {
    //     const data = reactive({
    //         email: ''
    //     })
    //     const router = useRouter();
    //     const submit = async () => {
    //         await fetch('https://localhost:44320/api/pizzavote/login',{
    //             method: 'POST',
    //             headers: {'Content-Type': 'application/json'},
    //             credentials: 'include',
    //             body: JSON.stringify(data)
    //         })
    //         await router.push('/')
    //     }

    //     return {
    //         data,
    //         submit
    //     }
    // }
    Data(){
        return {
            email: '',
            username: '',
            password: ''
        }
    },
    computed:{
        ...mapGetters('auth',{
            gettersLoginApiStatus:'getLoginApiStatus'
        })
    },
    methods: {
        ...mapActions('auth',{
            actionLogin: 'login'
        }),
        async login()
        {
            // const jsondata = axios.get('https://localhost:44320/api/pizzavote')
            // var json = JSON.parse(jsondata);
            // // var data_filter = jsondata.filter( element => element.id == this.email)
            // json.each(JSON.parse(json), function (idx, obj) {
            //     if (obj.website == 'mihail.gaberov@gmail.com') {
            //         // do whatever you want
            //         console.log(json)
            //     }
            // });
            console.log(this.email, this.username, this.password)
            await this.actionLogin({username: this.username, password: this.password});
            if(this.gettersLoginApiStatus === 'success'){
                alert('login success');
            }else{
                alert('login failed');
            }
        }
    }
}
</script>

<style>

</style>