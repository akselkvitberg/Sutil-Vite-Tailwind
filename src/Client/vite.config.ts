import { defineConfig } from "vite";

// vite.config.js
export default defineConfig({
  // config options
  server: {
    port: 8080,
    proxy: {
      '/api': {
        target: 'http://localhost:8090',
        changeOrigin: true,
      }
    }
  }
})
