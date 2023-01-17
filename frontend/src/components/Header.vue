<template>    
    <header>
           <div class="container-logo">
               <img src='/img/logo.png' alt="logo.png" />
               <h1>Agenda Virtual</h1>
           </div>
       </header >
</template>  

<script>
   export default{
       name: 'Header',    
   }
</script>

<style>
header {
    background:#2196F3;
    height: 220px;
    display: flex;
    align-items: center;
    justify-content: center;
}

.container-logo {
    display: flex;
    flex-direction: column;
    align-items: center;
}

.container-logo img {
    width: 235px;
}

.container-logo h1 {
    margin-top: 15px;
    font-size: 24px;
    color: #fff;
    text-align: center;
}
h1 {
    text-align: center;

}
</style>