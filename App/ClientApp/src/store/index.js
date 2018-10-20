import Vue from 'vue';
import Vuex from 'vuex';

import CartModule from './modules/cart';
import ProductModule from './modules/products';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {

  },
  modules: {
    cart: CartModule,
    products: ProductModule,
  },
});
