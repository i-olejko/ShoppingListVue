<template>
  <md-list-item>
    <md-avatar>
      <img :src="getImage" alt="People">
    </md-avatar>

    <div class="md-list-item-text">
      <span>{{item.name}}</span>
      <md-divider></md-divider>
      <span>Price: {{item.price}}$</span>
      <p>description: {{item.id}}</p>
    </div>

    <md-button class="md-icon-button md-list-action" @click="addToCart()">
      <md-icon class="md-primary">add_shopping_cart</md-icon>
    </md-button>

  </md-list-item>
</template>

<script>
import { mapActions } from 'vuex';

export default {
  name: 'ListItem',
  props: {
    item: {
      type: Object,
      required: true,
    },
  },
  computed: {
    getImage() {
      const id = Math.floor(Math.random() * 100);
      return `https://placeimg.com/40/40/nature/${id}`;
    },
  },
  methods: {
    ...mapActions('cart', ['addProductToCart']),
    addToCart() {
      const product = this.item;
      console.log(`going to add to cart item with id: ${product.id}`);
      this.addProductToCart(product);
    },
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
