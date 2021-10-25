<template>
  <div>
    <b-container>
      <div v-for="customer in customers">
        <div>
          <b-card>
            <b-card-title>{{ customer.firstName }} {{customer.lastName}}</b-card-title>
            <b-card-text>
              Email: {{ customer.email }}
            </b-card-text>
          </b-card>
        </div>
      </div>
    </b-container>
  </div>
</template>

<script>
  import CustomerService from '@/api-services/customer.service.js'

  export default {
    name: "customer",
    data() {
      return {
        customers: []
      }
    },
    created() {
      CustomerService.getAll().then((response) => {
        this.customers = response.data;
      });
    }
  }
</script>

<style>

</style>
