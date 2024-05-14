import * as THREE from 'three';

const scene = new THREE.Scene();
const camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);

const renderer = new THREE.WebGLRenderer();
renderer.setSize(window.innerWidth, window.innerHeight);
document.body.appendChild(renderer.domElement);

// Create a texture from the image
const texture = new THREE.TextureLoader().load('/img.jpg'); // Replace with your image path

const geometry = new THREE.BoxGeometry(1, 1, 1);
// Use MeshBasicMaterial with the texture
const material = new THREE.MeshBasicMaterial({ map: texture });

const cube = new THREE.Mesh(geometry, material);
scene.add(cube);

camera.position.z = 5;

// Defina a velocidade de rotação inicial
let rotationSpeed = 0.01;

// Adicione um ouvinte de eventos de clique ao documento
document.addEventListener('click', () => {
  // Aumente a velocidade de rotação quando clicado
  rotationSpeed += 0.02;
});

function animate() {
  requestAnimationFrame(animate);

  cube.rotation.x += rotationSpeed;
  cube.rotation.y += rotationSpeed;

  renderer.render(scene, camera);
}

animate();
