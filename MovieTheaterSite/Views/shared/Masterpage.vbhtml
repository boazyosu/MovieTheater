﻿
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Masterpage</title>
</head>
<body>
    <div class="wraper">
        <header class="header-background">
            <img src="content/images/background.png" alt="image" />
            <nav class="nav-bar">
                <div class="logo">
                    <img src="content/images/logo.png" alt="image" />
                </div>
                <div class="menu">
                    <a href="#">Home</a>
                    <a href="#">Product</a>
                    <a href="#">Promo</a>
                    <a href="#">About</a>
                    <a href="#">Contact</a>
                </div>
                <div class="research">
                    <i class="fa-solid fa-magnifying-glass"></i>
                </div>
            </nav>
            <div class="header-text">
                <div class="header-text-title">
                    <h1>Title Here</h1>
                </div>
                <div class="header-text-info">
                    <p>
                        Lorem ipsum dolor sit amet, consectetur
                        adipiscing elit. Vivamus lacinia odio vitae
                        vestibulum vestibulum.
                    </p>
                </div>
                <div class="header-text-btn">
                    <a href="#">Register Now</a>
                </div>
            </div>
        </header>

        <main class="main">
            @RenderBody()
        </main>

        <footer class="footer">
            <div class="footer-musicology">
                <h3>musicology</h3>
                <p>
                    Lorem ipsum dolor sit amet, consecte-
                    tur adipiscing elit. Aliquam at dignis-
                    sim nunc, id maximus ex. Etiam nec
                    dignissim elit, at dignissim enim.
                </p>
                <img src="content/images/Instagram.png" alt="image" />
                <img src="content/images/Facebook.png" alt="image" />
                <img src="content/images/Twitter.png" alt="image" />
                <img src="content/images/WhatsApp.png" alt="image" />
            </div>
            <div class="footer-info">
                <div class="footer-text">
                    <h3>about</h3>
                    <a href="#">History</a>
                    <a href="#">Our Team</a>
                    <a href="#">Brand Guidelines</a>
                    <a href="#">Terms & Conditions</a>
                    <a href="#">Privacy Policy</a>
                </div>
                <div class="footer-text">
                    <h3>services</h3>
                    <a href="#">How to Order</a>
                    <a href="#">Our Product</a>
                    <a href="#">Order Status</a>
                    <a href="#">Promo</a>
                    <a href="#">Payment Method</a>
                </div>
                <div class="footer-text">
                    <h3>other</h3>
                    <a href="#">Contact Us</a>
                    <a href="#">Help</a>
                    <a href="#">Privacy</a>
                </div>
            </div>
        </footer>
    </div>
</body>
</html>