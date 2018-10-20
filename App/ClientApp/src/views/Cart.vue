<template>
    <div class="wrapper">
        <md-list>
            <CartListItem v-for="(productFromCart, idx ) in cartItems"
                :key="idx"
                :cartItem="productFromCart"/>
            <md-divider></md-divider>
            <md-list-item>
                <span class="md-list-item-text">Total price: {{total}}$</span>
            </md-list-item>
        </md-list>
    </div>
</template>

<script>
import { mapState, mapGetters } from 'vuex';
import CartListItem from '../components/CartListItem.vue';

export default {
  name: 'Cart',
  components: {
    CartListItem,
  },
  computed: {
    ...mapState({
      cartItems: state => state.cart.items,
    }),
    ...mapGetters('cart', { total: 'GetTotalPrice' }),
  },
};
</script>

<style scoped>
.wrapper{
  height: 100%;
  overflow: hidden;
}
</style>
