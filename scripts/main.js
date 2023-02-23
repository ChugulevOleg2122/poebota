const firstDecada = 10
const secondDecada = 20
const thirdDeada = 30


const Container = document.querySelector('.js-change-on-press-key') 
const Input = document.querySelector('.input')
const ContentDiv = document.querySelector('.text-Content')
const Button = document.querySelector('.button')

Button.addEventListener('click' ,  () => {
  ContentDiv.textContent = Input.value
}) 
