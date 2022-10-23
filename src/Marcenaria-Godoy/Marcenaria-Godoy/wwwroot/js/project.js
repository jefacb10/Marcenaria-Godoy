﻿
let imagens = document.querySelectorAll('.small-img');
let modal = document.querySelector('.modal-img');
let modalImg = document.querySelector('#modal-imagem');
let btnClose = document.querySelector('#btn-close');
let srcVal = "";

for (let i = 0; i < imagens.length; i++) {
    imagens[i].addEventListener('click', function () {
        srcVal = imagens[i].getAttribute('src');
        modalImg.setAttribute("src", srcVal);
        modal.classList.toggle('modal_active');

    });
}

btnClose.addEventListener('click', function () {
    modal.classList.toggle('modal_active');
});


