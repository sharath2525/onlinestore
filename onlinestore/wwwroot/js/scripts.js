// Add hover effect to products
document.querySelectorAll('.product').forEach(product => {
    product.addEventListener('mouseover', () => {
        product.style.transform = 'scale(1.05)';
    });
    product.addEventListener('mouseout', () => {
        product.style.transform = 'scale(1)';
    });
});