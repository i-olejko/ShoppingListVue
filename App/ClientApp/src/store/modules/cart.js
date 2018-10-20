import axios from 'axios';

export default {
  namespaced: true,
  state: {
    cartId: null,
    items: [],
  },
  mutations: {
    updateCartId(state, newCartId) {
      state.cartId = newCartId;
    },
    addItemToCart(state, item) {
      state.items.push(item);
    },
  },
  actions: {
    // provided state, getters, commit, dispatch
    getNewCartId({ commit }) {
      axios.get('/api/cart')
        .then((result) => {
          commit('updateCartId', result.data.newCartID);
        })
        .catch(console.error);
    },
  },
};
