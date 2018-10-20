module.exports = {
  devServer: {
    proxy: {
      '/api': {
        target: 'http://localhost:8376',
        changeOrigin: true,
      },
    },
  },
};
