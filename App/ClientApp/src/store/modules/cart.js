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
      const itemToAdd = Object.assign({}, item, { amount: 1 });
      const idxOfExistingItem = state.items.findIndex(i => i.id === item.id);
      if (idxOfExistingItem !== -1) { // state.items.some(i => i.id === item.id)
        itemToAdd.amount = state.items[idxOfExistingItem].amount + 1;
        state.items.splice(idxOfExistingItem, 1, itemToAdd);
      } else {
        state.items.push(itemToAdd);
      }
      console.log(`adding item to cart with amount: ${itemToAdd.amount}`);
    },
  },
  getters: {
    cartCartItemsAmount(state) {
      let retVal = 0;
      if (state.items.length > 0) {
        retVal = state.items.map(el => el.amount).reduce((a, b) => a + b, 0);
      }
      return retVal;
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
    addProductToCart({ commit }, product) {
      commit('addItemToCart', product);
      // const items = [...state.items, product];
      // canst dataToSend = {
      //   cartID: state.cartId,
      //   products: items,
      // };
      // return axios.post('/api/cart', dataToSend)
      //   .then(() => commit('addItemToCart', product));
    },
  },
};
