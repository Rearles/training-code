document.addEventListener('DOMContentLoaded', () => {
  putTextInBody('hello from ts');
});

function putTextInBody(text: string) {
  document.body.innerHTML = text;
}
