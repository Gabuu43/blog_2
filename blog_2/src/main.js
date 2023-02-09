import Vue from 'vue'
import App from './App.vue'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue/dist/bootstrap-vue.css';
import VueRouter from 'vue-router';

Vue.use(VueRouter);
Vue.use(BootstrapVue);
Vue.use(IconsPlugin);

Vue.config.productionTip = false

const router = new VueRouter({
    routes: [
        {
            path: '/Home',
            name: 'Home',
            component: () => import('./Home.vue')
        },
        {
            path: '/PagPost',
            name: 'PagPost',
            component: () => import('./PagPost.vue')
        },
        {
            path: '/PagPost/:id',
            name: 'PagPostId',
            component: () => import('./PagPost.vue')
        }
    ]

})

new Vue({
    router,
    render: h => h(App),
}).$mount('#app')