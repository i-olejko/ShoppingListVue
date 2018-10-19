<template>
  <div class="hello">
    hello page component
    <md-button @click="test()" class="md-raised">Default</md-button>
    {{index}}
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  data() {
    return { index: 0 };
  },
  methods: {
    test() {
      this.index += 1;
    },
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
