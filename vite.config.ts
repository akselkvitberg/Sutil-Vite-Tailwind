import { defineConfig } from "vite";

// vite.config.js
export default defineConfig({
  // config options
  server: {
    proxy: {
      '/api': {
        target: 'http://localhost:8085',
        changeOrigin: true,
      }
    }
  }
})
