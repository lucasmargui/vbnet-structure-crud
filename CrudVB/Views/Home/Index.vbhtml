@Code
    ViewData("Title") = "Home Page"
End Code

 <!-- Cabeçalho -->

<style>


body {
    margin: 0;
    font-family: sans-serif;
}

section.hero {
    /* Sizing */
    width: 100vw;
    height: 100vh;
    
    /* Flexbox stuff */
    display: flex;
    justify-content: center;
    align-items: center;
    
    /* Text styles */
    text-align: center;
    color: white; /* ADD THIS LINE */
    
    /* Background styles */
    background-image: linear-gradient(rgba(0, 0, 0, 0.5),rgba(0, 0, 0, 0.5)), url('https://fastly.picsum.photos/id/201/5000/3333.jpg?hmac=NE8fOMa8u9PBfkq4AVwEoJdRqoPTNwUsyKvKWuXyNCk');
    background-size: cover;
    background-position: center center;
    background-repeat: no-repeat;
    background-attachment: fixed;
}

.hero h1 {
    /* Text styles */
    font-size: 5em;
    
    /* Margins */
    margin-top: 0;
    margin-bottom: 0.5em;
}

.hero h2 {
    /* Text styles */
    font-size: 2em;
    color: white;

}



.hero .btn {
	box-shadow:inset 4px 4px 0px -17px #a6827e;
	background:linear-gradient(to bottom, #7d5d3b 5%, #634b30 100%);
	background-color:#7d5d3b;
	border:1px solid #54381e;
	display:inline-block;
	cursor:pointer;
	color:#ffffff;
	font-family:Arial;
	font-size:24px;
	padding:15px 39px;
	text-decoration:none;
	text-shadow:-2px 1px 0px #4d3534;
}
.btn:hover {
	background:linear-gradient(to bottom, #634b30 5%, #7d5d3b 100%);
	background-color:#634b30;
}
.btn:active {
	position:relative;
	top:1px;
}

.product-grid {
    display: flex;
    flex-wrap: wrap;
    gap: 20px;
    padding: 20px;
}

.product-card {
    background: #fff;
    border: 1px solid #ddd;
    border-radius: 4px;
    padding: 10px;
    text-align: center;
    width: 200px;
}

.product-card img {
    width: 100%;
    height: auto;
}

.benefits, .testimonials, .blog {
    padding: 20px;
    background: #fff;
    margin: 20px 0;
}

.benefits .benefit-item, .testimonials .testimonial {
    text-align: center;
}

.benefits img {
    width: 50px;
    height: 50px;
}

.footer {
    background-color: #8e735b; /* Cor marrom clara */
    color: #fff;
    padding: 20px;
    text-align: center;
}

.footer .social-links img {
    width: 24px;
    height: 24px;
    margin: 0 5px;
}

.footer .newsletter input {
    padding: 5px;
    border: none;
    border-radius: 4px;
}

.footer .newsletter button {
    padding: 5px 10px;
    border: none;
    background-color: #6c4f3d; /* Cor marrom escura */
    color: #fff;
    border-radius: 4px;
    cursor: pointer;
}

</style>

<!-- Seção de Destaques -->
<section class="hero">
    <div class="hero-inner">
        <h1>My awesome website</h1>
        <h2>Look at this website and bask in its amazing glory!</h2>
        <a href="https://example.com/" class="btn">Go ahead...</a>
    </div>
</section>
<!-- Seção de Produtos em Destaque -->
<section id="products">
    <h2>Produtos em Destaque</h2>
    <div class="product-grid">
        <!-- Exemplo de produto -->
        <div class="product-card">
            <img src="https://placehold.co/600x400" alt="Produto 1">
            <h3>Nome do Produto</h3>
            <p>Descrição curta do produto.</p>
            <p>Preço: R$XX,XX</p>
            <a href="#product-details" class="button">Ver Detalhes</a>
        </div>
        <!-- Adicionar mais produtos -->
    </div>
</section>
<!-- Seção de Benefícios -->
<section class="benefits">
    <div class="benefit-item">
        <img src="https://placehold.co/600x400" alt="Qualidade Garantida">
        <h3>Qualidade Garantida</h3>
        <p>Os melhores materiais para sua mobília.</p>
    </div>
    <div class="benefit-item">
        <img src="https://placehold.co/600x400" alt="Entrega Rápida">
        <h3>Entrega Rápida</h3>
        <p>Receba seus produtos no menor tempo possível.</p>
    </div>
    <div class="benefit-item">
        <img src="https://placehold.co/600x400" alt="Preços Competitivos">
        <h3>Preços Competitivos</h3>
        <p>Oferecemos os melhores preços do mercado.</p>
    </div>
</section>
<!-- Depoimentos de Clientes -->
<section class="testimonials">
    <h2>O que nossos clientes dizem</h2>
    <!-- Exemplo de depoimento -->
    <div class="testimonial">
        <p>"Ótima experiência de compra e excelente atendimento!"</p>
        <span>Cliente Satisfeito</span>
    </div>
    <!-- Adicionar mais depoimentos -->
</section>
<!-- Blog ou Dicas de Móveis -->
<section class="blog">
    <h2>Dicas e Tendências</h2>
    <a href="#blog-post1">Como escolher o material ideal para seus móveis</a>
    <!-- Adicionar mais links para postagens -->
</section>
<!-- Rodapé -->
<footer>
    <div class="contact-info">
        <p>Telefone: (00) 0000-0000</p>
        <p>Email: contato@empresa.com</p>
        <p>Endereço: Rua Exemplo, 123, Cidade - Estado</p>
    </div>
    <div class="social-links">
        <a href="#facebook"><img src="https://placehold.co/50x50" alt="Facebook"></a>
        <a href="#twitter"><img src="https://placehold.co/50x50" alt="Twitter"></a>
        <a href="#instagram"><img src="https://placehold.co/50x50" alt="Instagram"></a>
    </div>
    <div class="useful-links">
        <a href="#privacy">Política de Privacidade</a>
        <a href="#terms">Termos de Serviço</a>
        <a href="#faq">FAQ</a>
    </div>
    <div class="newsletter">
        <p>Inscreva-se na nossa newsletter:</p>
        <input type="email" placeholder="Seu e-mail">
        <button type="submit">Inscrever-se</button>
    </div>
</footer>
