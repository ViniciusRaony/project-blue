<template>
    <div class="form-demo">
        <section>
            <div class="flex justify-content-center">
                <div class="card">
                    <h2 class="text-center">REGISTRO AGENDA</h2>
                    <form class="p-fluid">
                        <div class="field">
                            <div class="p-inputgroup">
                                <span class="p-inputgroup-addon">
                                <i class="pi pi-user"></i>
                                </span>
                                <InputText placeholder="Nome" v-model="nome" required/>
                            </div>  
                        </div>
                        <div class="field">
                            <div class="p-inputgroup">
                                <span class="p-inputgroup-addon">
                                <i class="pi pi-envelope"></i>
                                </span>
                                <InputText placeholder="Email" v-model="email" v-validate="'required|email'"/>
                            </div>                           
                        </div>
                        <div class="field">
                            <div class="p-inputgroup">
                                <span class="p-inputgroup-addon">
                                <i class="pi pi-phone"></i>
                                </span>
                                <InputText placeholder="Telefone" v-model="telefone" required/>
                            </div>  
                        </div>
                        <Button type="submit" label="Enviar" class="mt-2" v-on:click="addAgenda"></Button>
                        
                    </form>
                </div>
            </div>
        </section> 
    </div>
    <br>
    <div>
        <DataTable :value="agendas" responsiveLayout="scroll">
            <Column field="id" header="Id"></Column>
            <Column field="nome" header="Nome"></Column>
            <Column field="email" header="Email"></Column>
            <Column field="telefone" header="Telefone"></Column>
            <Column field="status" header="">
                <template #body="slotProps">
                    <Button icon="pi pi-pencil" class="p-button-rounded p-button-success mr-2" @click="openEdit(slotProps.data)"  />
                    <Button icon="pi pi-trash" class="p-button-rounded p-button-warning" @click="deleteAgenda(slotProps.data.id)" />
                </template>
            </Column>
            
        </DataTable>
    </div>
    <Dialog v-model:visible="displayBasic" :style="{width: '450px'}" header="Atualizar Cadastro" :modal="true" class="p-fluid">
        <div class="field">
            <div class="p-inputgroup">
                <span class="p-inputgroup-addon">
                <i class="pi pi-user"></i>
                </span>
                <InputText placeholder="Nome" v-model="agenda.nome"/>
            </div>  
        </div>
        <div class="field">
            <div class="p-inputgroup">
                <span class="p-inputgroup-addon">
                <i class="pi pi-envelope"></i>
                </span>
                <InputText placeholder="Email" v-model="agenda.email"/>
            </div>                           
        </div>
        <div class="field">
            <div class="p-inputgroup">
                <span class="p-inputgroup-addon">
                <i class="pi pi-phone"></i>
                </span>
                <InputText placeholder="Telefone" v-model="agenda.telefone"/>
            </div>  
        </div>
        <template #footer>
            <Button label="Sair" icon="pi pi-times"  @click="closeEdit" autofocus class="p-button-text"/>
            <Button label="Salvar" icon="pi pi-check" @click="updateAgenda(agenda.id), closeEdit" />
        </template>
    </Dialog>    
   
</template>

<script>
import axios from 'axios';
export default {
    name: "Agenda",
    data()
    {
        return {
            agendas: [],
            nome: '',
            email: '',
            telefone: '',            
            displayBasic: false
        }
    },    
    async mounted()
    {     
        this.loadData()
    },
    methods:{
        async loadData()
        {
            let result = await axios.get("http://localhost:5236/v1/agendas");
            this.agendas = result.data;
        },
        async addAgenda()
        {
            if(!this.nome || !this.email || !this.telefone){
                alert("Por favor, preencha todos os campos!");
                return;
            }
            console.warn(this.agendas)
            const result = await axios.post("http://localhost:5236/v1/agendas",{
            nome:this.nome,
            email:this.email,
            telefone:this.telefone,
            });                       
        }, 
        openEdit(agenda) {
            this.displayBasic = true;
            this.agenda = {...agenda};           
        },
        closeEdit() {
            this.displayBasic = false;
        },
        async deleteAgenda(id)
        {            
            let result = await axios.delete('http://localhost:5236/v1/agendas/'+id);
            console.warn(result);
            if(result.status==200)
                this.loadData()            
        },  
        async updateAgenda(id)
        {            
            const result = await axios.put("http://localhost:5236/v1/agendas/"+id,{
            nome:this.agenda.nome,
            email:this.agenda.email,
            telefone:this.agenda.telefone,
            });   
            console.warn(result);
            if(result.status==200)
                this.displayBasic = false;
                this.loadData()            
        }
    },       
}
</script>

<style lang="scss" scoped>
.form-demo {
    .card {
        min-width: 450px;
    } form {
        margin-top: 2rem;
    }
    .field {
        margin-bottom: 1.5rem;
    }

    @media screen and (max-width: 960px) {
        .card {
            width: 80%;
        }
    }
}
</style>