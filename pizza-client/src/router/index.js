import {createRouter, createWebHistory} from 'vue-router'

import Dashboard from '../components/Dashboard.vue'
import Login from '../components/Login.vue'
import Add from '../components/test/Add.vue'

const routes = [
    
    {path: '/', component: Dashboard},
    {path: '/Login', component: Login},
    {path: '/test', component: Add}
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router