import {jwtDecrypt} from '../../shared/jwtHelper';

const state = () => ({
    authData: {
        token: '',
        refreshToken: '',
        username: '',
        userid: '',
        exp: ''
    },
    loginApiStatus: ''
});

const getters = {
    getLoginApiStatus(state){
        return state.loginApiStatus;
    }
};

const actions = {
    async login({commit}, payload){
        console.log(payload)
        const data = {
            access_token : "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6InRlc3QiLCJzdWIiOjEsImlhdCI6MTYwODIwNjE3OSwiZXhwIjozNjAxNjA4MjA2MTc5fQ.BcHKT6ffgvkt0EztkJT35a0Yc7iWF9wkeNxKB4wSJEQ",
            refresh_token: ''
        };
        commit('setauthData', data)
        commit('setLoginApiStatus', 'success')
    }
};

const mutations = {
    setauthData(state, data){
        const decryptedAuth = jwtDecrypt(data.access_token);
        console.log(decryptedAuth);

        localStorage.setItem('access_token', data.access_token);
        localStorage.setItem('refresh_token', data.refresh_token);

        const newAuthData = {
            token: data.access_token,
            refreshToken: data.refresh_token,
            username: decryptedAuth.username,
            userid: decryptedAuth.sub,
            exp: decryptedAuth.exp
        };
        state.authData = newAuthData;
    },
    setLoginApiStatus(state, data){
        state.loginApiStatus = data;
    }
};

export default {
    namespaced:true,
    state,
    getters,
    actions,
    mutations
}