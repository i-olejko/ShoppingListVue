<template>
    <div>
        <md-list class="md-triple-line">
        <ListItem v-for=" (product, idx ) in allProducts" :key="idx"  :item="product"/>

        </md-list>
    </div>
</template>

<script>
import ListItem from '@/components/ListItem.vue';
import { mapActions } from 'vuex';

export default {
  name: 'Shop',
  components: {
    ListItem,
  },
  props: {
    id: {
      type: [Number, String],
      validator(value) {
        return Number.isInteger(Number(value));
      },
    },
  },
  data() {
    return {
      allProducts: [],
    };
  },
  created() {
    this.getAllProducts().then(() => this.allProducts = this.$store.state.products.all);
  },
  methods: {
    ...mapActions('products', ['getAllProducts']),
  },
};
</script>

<style>
</style>
