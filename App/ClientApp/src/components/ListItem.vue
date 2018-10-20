<template>
  <md-list-item>
    <md-avatar>
      <img :src="getImage" alt="People">
    </md-avatar>

    <div class="md-list-item-text">
      <span>name: {{item.name}}</span>
      <span>Price: {{item.price}}$</span>
      <p>description: {{item.id}}</p>
    </div>

    <md-button class="md-icon-button md-list-action">
      <md-icon class="md-primary">add_shopping_cart</md-icon>
    </md-button>
  </md-list-item>
</template>

<script>
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
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
