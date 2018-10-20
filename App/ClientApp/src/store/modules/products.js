import axios from 'axios';

export default {
  namespaced: true,
  state: {
    all: [],
  },
  mutations: {
    updateProducts(state, newProducts) {
      state.all = newProducts;
    },
  },
  actions: {
    getAllProducts({ commit }) {
      axios.get('/api/Products')
        .then((result) => {
          commit('updateProducts', result.data);
        })
        .catch(console.error);
    },
  },
};
