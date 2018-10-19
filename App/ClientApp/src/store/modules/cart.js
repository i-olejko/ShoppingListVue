export default {
  namespaced: true,
  state: {
    cart: [],
  },
  mutations: {
    addItemToCart(state, item) {
      state.cart.push(item);
    },
  },
};
