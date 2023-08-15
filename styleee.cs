* {
    margin: 0;
   padding: 0;
    border: 0;
    outline: 0;
    text-decoration: none;
    list-style: none;
    box-sizing: border-box;


}
:root{
    --color-primary:#6c63ff;
    --color-success: #00bf8e;
    --color-warning: #f7c94b;
    --color-danger: #f75842;
    --color-danger-variant:rgba(247,88,66,0.4) ;
    --color-white:#fff;
    --color-light:rgba(255,255,255,0.7);
    --color-black: #000;
    --color-bg: #1f2641;
    --color-bg1: #2e3267;
    --color-bg2:  #424890;

    --container-width-lg:80%;
    --container-width-md:90%;
    --container-width-sm:94%;

   --transition:all 400ms ease;

}
body{
    font-family: 'Montserrat', sans-serif;
    line-height: 1.7;
    color: var(--color-white);
    background-color: var(--color-bg);
}
.container{
    width: var(--container-width-lg);
    margin :0 auto;
}

section{
    padding: 6rem 0;
}
section h2
{
    text-align: center;
    margin-bottom: 4rem;
}
h1,h2,h3,h4,h5{
    line-height: 1,2;
}
h1{
    font-size: 2.4rem;
}
h2{
    font-size: 2rem;
}
h3{
    font-size: 1.6rem;
}
h4{
    font-size: 1.4rem;
}
a{
    color: var(--color-white);
}
img{
    width: 100%;
    display: block;
    object-fit: cover;
}
.btn{
    display: inline-block;
    background: var(--color-white);
    color: var(--color-black);
    padding: 1rem 2rem;
    border: solid transparent;
    font-weight: 500;
   transition: all 400ms ease;

}
.btn:hover{
    background: transparent;
    color: var(--color-white);
    border-color: var(--color-white);
}
.btn-primary{
    color: var(--color-white);
    background-color: var(--color-danger);
}
nav{
    background-color: transparent;
    width: 100vw;
    height: 5rem;
    position:fixed;
    top: 0;
    z-index: 11;
}
.window-scroll{
    background: var(--color-primary);
    box-shadow: 0 1rem 2rem rgba(0, 0, 0, 0.2);
}
.nav_container{
    height: 100%;
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-content: center;
}
nav button{
    display: none;
}
.nav_menu {
display: flex;
gap: 4rem;
align-items: center;
}
.nav_menu a{
    font-size: 0.9rem;
    transition: all 400ms ease;
}
.nav_menu a:hover{
    color: var(--color-bg2);
}
.EGATOR{
    margin-top: 25%;
}
.header{
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: space-evenly;
    position: relative;
    top: 1rem;
    height: 70vh;
   
}
.header_left{
    width: 50%;
}
.header_right img{
    height: 60vh;
}
.categories{
    background: var(--color-bg1);
    height: 50rem;
}
.categories h1{
    line-height: 1;
    margin-bottom: 4rem;
}

.categories_container{
    display: grid;
    grid-template-columns: 40% 60%;
   
}
.categories_left{
    margin-right: 4rem;
}
.firstpage{
    height: 100vh;
}
.categories_left p{
    margin: 1rem 0 3rem;
}.categories_right{
    display: grid;
    grid-template-columns: repeat(3,1fr);
    gap: 1.2rem;
}
.category{
    background: var(--color-bg2);
    padding: 2rem;
    border-radius: 2rem;
    transition: var(--transition);

}
.category:hover{
    box-shadow: 0em 3rem 3rem rgba(0, 0, 0, 0.3);
}
.category_icon{
    background-color: var(--color-primary);
    padding: 0.7rem;
border-radius: 0.9rem;
}
.category h5{
    margin: 2rem 0 1rem;
}
.category:nth-child(2) .category_icon{
    background-color: var(--color-danger);
}
.category:nth-child(3) .category_icon{
    background-color: var(--color-success);
}
.category:nth-child(4) .category_icon{
    background-color: var(--color-warning);
}
.category:nth-child(5) .category_icon{
    background-color: var(--color-primary);
}
.courses{
padding-top: 2rem;
}
.course{
    margin: 1rem;
  background: var(--color-bg1);
  text-align: center;
  border: 1px solid transparent;
  height: 105vh;
 
}
.course:hover{
    background: transparent;
    border: var(--color-primary);
    transition: var(--transition);
}

.courses_container{
    display: flex;
    flex-direction: row;
    flex-wrap: nowrap;
    justify-content: space-between;
    align-items: center;
    gap: 1rem;

}
.courses_container1{
    display: flex;
    flex-direction: row;
    flex-wrap: nowrap;
    justify-content: space-between;
    align-items: center;
    gap: 1rem;

}
.courses_container3{
    display: flex;
    flex-direction: row;
    flex-wrap: nowrap;
    justify-content: space-between;
    align-items: center;
    gap: 1rem;

}
.course_image1 img{
    height: 150px;
}
.course_image3 img{
height: 150px;
}
.course_image2 img{
    height: 150px;
}

.course_info p {
    font-size: 0.9rem;
    margin: 1.2rem 0 2rem;

}
.faqs{
    background: var(--color-bg1);
    box-shadow: inset 0 0 3rem rgba(0, 0, 0, 0.5);
}
.faqs_container{
   display: grid;
   grid-template-columns: 1fr 1fr;
   gap: 1rem;
  
 
 
}
.faq{
    padding: 2rem;
    display: flex;
  background: var(--color-primary);
 gap: 1.4rem;
 height: fit-content;
 align-items: center;
 cursor: pointer;
}
.faq h4{
    font-size: 1rem;
    line-height: 2.2;
}
.faq_icon{
    align-self: flex-start;
    font-size: 1.2rem;
    
}
.faq p{
    margin-top: 0.8rem;
    display: none;
}
.faq.open p{
display: block;
}





.testimonials_container{
    overflow-x: hidden;
    position: relative;
    margin-bottom: 5rem;

}
.testimonial{
    padding-top: 2rem;
}
.avatar{
    width: 6rem;
    height: 6rem;
    border-radius: 50%;
    overflow: hidden;
    margin: 0 auto;
    border: 1rem solid var(--color-bg1);
}
.testimonial_info{
    text-align: center;
}
.testimonial_body{
    background: var(--color-primary);
    padding: 2rem;
    margin-top: 3rem;
    position: relative;
}
.testimonial_body ::before{
    content: "";
    display: block;
    background:linear-gradient(
        135deg,
    transparent,
    var(--color-primary),
    var(--color-primary),
    var(--color-primary));
    width: 3rem;
    height: 3rem;
    position: absolute;
left: 48%;
    top: -1.5rem;
    transform: rotate(45deg);
}
.footer{
   background: var(--color-bg1);
   padding-top: 5rem;
   font-size: 0.9rem;
   height: 100vh;
}
.footer_container{
    display: flex;
    flex-direction: row;
    justify-content:space-evenly;
    gap: 5rem;

}
.footer_container > div h4{
    margin-bottom: 1.2rem;
    
}
footer ul li:hover{
    text-decoration: underline;
}
.footer_socials{
    display: flex;
    flex-direction: row;
    justify-content: space-evenly;
    margin-top: 2rem;
}
.footer_copyright{
    text-align: center;
    margin-top: 3rem;
}
.footer_copyright1{
    text-align: center;
    margin-top: 16rem;
    font-size: 1.2rem;
}
.about_achievments-container{
    display: flex;
    flex-direction: row;
  
   
}

.about_achievments-left{
    display: grid;
    grid-template-columns: repeat(3,1fr);
    gap: 2rem;
}
.about_achievments-left img{
    width: 400px;
    height: 300px;
 }
 .achievments_cards{
    display: flex;
    flex-direction: row;
    gap: 1.5rem;
 }
 .achievment_card{
    background: var(--color-bg1);
    padding: 1.5rem;
    border-radius: 1rem;
    text-align: center;
    transition: var(--transition);
 }
 
.achievment_card:hover{
    background: var(--color-primary);
}
 
.achievment_icon{
    background-color: var(--color-danger);
    padding: 0.7rem;
border-radius: 0.9rem;

}

.achievment_card:nth-child(2) .achievment_icon{
    background-color: var(--color-warning);
}
.achievment_card:nth-child(3) .achievment_icon{
    background-color: var(--color-success);
}

.team{
    background: var(--color-bg1);
    box-shadow: inset 0 0 3rem rgba(0, 0, 0, 0.5);
}
.team_container{
    display: grid;
  grid-template-columns: repeat(4,1fr);
    gap: 1rem;
}

 .team_member{
    background: var(--color-bg2);
    padding: 2rem;
    border: 1px solid transparent;
    transition: var(--transition);
    position: relative;
    overflow: hidden;
 }
 .team_member:hover{
    background: transparent;
    border-color: var(--color-primary);
 }
.team_member_image img{
    filter: saturate(0);
}
.team_member:hover img{
    filter: saturate(1); 
}
.team_member-teams{
text-align: center;
margin-top: 1.4rem;
}
.team_member-teams p{
    color: var(--color-light);

}
.team_member-socials{
    position: absolute;
    top: 50%;
    transform: translateY(-50%);
    right: -100%;
    display: flex;
    flex-direction: column;
    background: var(--color-primary);
    border-radius: 1rem 0 0 1rem;
box-shadow: -2rem 0 2rem rgba(0, 0, 0, 0.3);
transition: var(--transition);

    
}
.team_member:hover .team_member-socials{
    right:0;
}

.team_member-socials a {
    padding: 1rem;
}


.contact_container5{
    background: var(--color-bg1);
    padding: 4rem;
    display: grid;
    grid-template-columns: 40% 60%;
 gap: 4rem;
 height: 30rem;
 margin: 7rem auto;
border-radius: 1rem;
}
.contact_aside{
    background: var(--color-primary);
    padding: 3rem;
    border-radius: 1rem;
    position: relative;
    bottom: 10rem;
    width: 66vh;
}
.aside_image{
    width: 12rem;
    margin-bottom: 2rem;
}
.contact_aside h2{
    text-align: left;
    margin-bottom: 1rem;
}
.contact_aside p{
    font-size: 0.9rem;
    margin-bottom: 2rem;
}
.contact_details{
display: flex;
position: relative;
right: 2rem;
gap: 1rem;
margin-bottom: 1rem;
}
.footer_social{
    display: flex;
    flex-direction: row;
    justify-content: space-evenly;
    margin-top: 2rem;

}
.footer_social a{
    background: var(--color-bg2);
    padding: 0.5rem;
    border-radius: 50%;
    font-size: 0.9rem;
    transition: var(--transition);
}
.footer_social a:hover{
    background: transparent;
}
.contact_form{
    display: flex;
    flex-direction: column;
    gap:1.2rem ;
    margin-right: 4rem;

}
.form_name{
    display: flex;
    gap: 1.2rem;
}
.contact_form input[type="text"] {
width: 50%;
}
input,textarea{
    width: 100%;
    padding: 1rem;
    background-color: var(--color-bg);
    color: var(--color-white);

}
.contact_form .btn{
    width: max-content;
    margin-top: 1rem;
    cursor: pointer;

}
