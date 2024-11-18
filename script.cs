let cart = [];
let totalPrice = 0;

function addToCart(item, price) {
    cart.push({ item, price });
    totalPrice += price;
    updateCart();
}

function updateCart() {
    const cartList = document.getElementById("cart-list");
    const totalElement = document.getElementById("total-price");

    cartList.innerHTML = "";
    cart.forEach((cartItem) => {
        const li = document.createElement("li");
        li.textContent = `${cartItem.item} - $${cartItem.price}`;
        cartList.appendChild(li);
    });

    totalElement.textContent = totalPrice;
}

document.getElementById("order-form").addEventListener("submit", function (e) {
    e.preventDefault();

    const name = document.getElementById("name").value;
    const address = document.getElementById("address").value;

    if (cart.length === 0) {
        alert("Your cart is empty!");
        return;
    }

    alert(`Thank you, ${name}! Your order will be delivered to ${address}.`);
    cart = [];
    totalPrice = 0;
    updateCart();
    e.target.reset();
});
