<template>
  <div class="home">
    <!-- <img alt="Vue logo" src="../assets/logo.png"> -->
    <div class="wrapper">
        <md-toolbar md-elevation="0">
          <md-button @click="f_onNewCart()" class="md-raised">
            Start new cart
            <md-icon>shopping_cart</md-icon>
            </md-button>
        </md-toolbar>
    </div>


  </div>
</template>

<script>
import { mapActions } from 'vuex';

export default {
  name: 'home',
  data() {
    return {
      idx: 0,
    };
  },
  computed: {
    cartId() {
      return this.$store.state.cart.cartId;
    },
  },
  methods: {
    ...mapActions('cart', ['getNewCartId']),
    f_onNewCart() {
      console.log('going to dispatch action getNewCartId');
      this.getNewCartId()
        .then(() => {
          // debugger;
          // const id = this.$store.state.cart.cartId;
          this.$router.push({
            name: 'shop',
            params: { id: this.$store.state.cart.cartId },
          });
        });
    },
  },
};
</script>

<style scoped>
.home{
  border: 1px solid rgba(#000, .12);
  padding-top: 20%;
}
.wrapper {
  width: 50%;
  margin: 0 auto;

}
</style>
