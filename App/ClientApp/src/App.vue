<template>
  <div class="page-container">
    <md-app>
      <md-app-toolbar class="md-primary">
        <span class="md-title">Shopping Cart</span>
      </md-app-toolbar>

      <md-app-drawer md-permanent="full">
        <md-toolbar class="md-transparent" md-elevation="0">
          Navigation
        </md-toolbar>

        <md-list>
          <md-list-item>
            <router-link class="nav-link" to="/">
              <md-icon>home</md-icon>
              <span class="md-list-item-text">Home</span>
            </router-link>
          </md-list-item>
          <md-list-item>
            <router-link class="nav-link" to="/Shop">
              <md-icon>shopping_basket</md-icon>
              <span class="md-list-item-text">Shop</span>
            </router-link>
          </md-list-item>
        </md-list>
      </md-app-drawer>

      <md-app-content>
        <router-view/>
      </md-app-content>
    </md-app>
  </div>
</template>

<script>
export default {
  name: 'App',
};
</script>

<style lang="scss" scoped>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
.md-app{
  height: 95vh;
  border: 1px solid rgba(#000, .12);
}
a.nav-link {
  color: inherit;
  display: flex;
  text-decoration: none;
  .md-icon{
    margin-right: 1em;
  }
  .md-list-item-text{
    align-self: center;
  }
  i,span{
    text-decoration-line: none;
  }
}
// div.md-list-item-conten>a.nav-link :hover {
//   text-decoration: none;
// }

</style>
