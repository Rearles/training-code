const path = require('path');

module.exports = {
  mode: 'development',
  entry: './out/main.js',
  output: {
    filename: 'main.js',
    path: path.resolve(__dirname, 'dist')
  }
};
