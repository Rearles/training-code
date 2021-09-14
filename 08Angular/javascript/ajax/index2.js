'use strict';

document.addEventListener('DOMContentLoaded', () => {
  const resultsElement = document.createElement('div');
  const errorElement = document.createElement('div');
  errorElement.style.color = 'red';

  const url = 'https://newton.now.sh/api/v2/simplify/2^2%2b2(2)';

  function contactApi() {
    if (resultsElement.parentNode) {
      document.body.remove(resultsElement);
    }
    if (errorElement.parentNode) {
      document.body.remove(errorElement);
    }

    fetch(url) // returns a promise of a Response (but the whole body is not downloaded)
      .then(response => {
        if (response.ok) {
          return response.json(); // returns a promise of the body downloaded &
          // deserialized as json
        }
        throw response.status;
      })
      .then(obj => {
        resultsElement.textContent = obj.result;
        document.body.append(resultsElement);
      })
      .catch(error => {
        errorElement.textContent = `error ${error}`;
        document.body.append(errorElement);
      });
  }

  const form = document.getElementById('calculate-form');
  form.addEventListener('submit', event => {
    event.preventDefault();

    contactApi();
  });
});
