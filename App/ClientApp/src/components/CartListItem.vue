<template>
    <md-list-item>
        <span class="md-list-item-text">
            {{cartItem.name}}
            <i>{{cartItem.price}}$</i>
        </span>
        <md-button class="md-icon-button md-list-action" @click="increase()">
          <md-icon class="md-primary">add</md-icon>
        </md-button>
        <md-button class="md-icon-button md-list-action" @click="decrease()">
          <md-icon class="md-primary">remove</md-icon>
        </md-button>
        <span class="amount">
            <md-chip>{{cartItem.amount}}</md-chip>
        </span>
    </md-list-item>
</template>

<script>
import { mapActions } from 'vuex';

export default {
  name: 'CartListItem',
  props: {
    cartItem: {
      type: Object,
      required: true,
    },
  },
  methods: {
    ...mapActions('cart', ['incrementAmount', 'decrementAmount']),
    increase() {
      this.incrementAmount(this.cartItem.id);
    },
    decrease() {
      this.decrementAmount(this.cartItem.id);
    },
  },
};
</script>

<style scoped>
.amount{
    margin-left: 1em;
}
</style>
