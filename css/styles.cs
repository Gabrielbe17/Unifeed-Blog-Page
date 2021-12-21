html {
  font-size: 16px;
  font-family: "Noto Sans", sans-serif;
}

nav, footer {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-between;
}

.text {
  color: #666565;
  line-height: 1.6em;
}

.container {
  min-height: 100vh;
  width: 100%;
  max-width: 90em;
  margin: 0 auto;
}
.container > * {
  padding: 1em;
}

header ul {
  list-style-type: none;
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: none;
  gap: 1em;
}
header ul li {
  cursor: pointer;
  transition: opacity, transform 0.25s ease-in-out;
}
header ul li:hover {
  opacity: 0.85;
  transform: scale(1.1);
}
header ul .active {
  background-color: #EE7C0D;
  font-weight: 600;
  padding: 1em;
  border-radius: 0.55em;
}
@media screen and (max-width: 650px) {
  header ul {
    display: none;
  }
}
header .toggle-menu {
  display: none;
}
@media screen and (max-width: 650px) {
  header .toggle-menu {
    display: flex;
  }
}

main article .bg-image {
  width: 100%;
  height: 18em;
}
main article img {
  width: 100%;
  height: auto;
}
main article .bg-image-1 {
  background: url(../Assets/MainArticleImage.png) no-repeat;
}
main article .bg-image-2 {
  background: url(../Assets/Article-1-Image.png) no-repeat;
}
main article .bg-image-3 {
  background: url(../Assets/Article-2-Image.png) no-repeat;
}
main article .bg-image-4 {
  background: url(../Assets/Article-3Image.png) no-repeat;
}
main article .profile {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: none;
  gap: 1.5em;
}
main article .profile p {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: none;
  gap: 0.2em;
}
main article .profile span {
  opacity: 0.55;
}
main article .profile-img {
  max-width: 4.65em;
}
@media screen and (min-width: 1100px) {
  main .secondary {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(6em, 1fr));
    align-content: center;
    gap: 3em;
  }
}

footer {
  flex-wrap: wrap;
}

/*# sourceMappingURL=styles.cs.map */
