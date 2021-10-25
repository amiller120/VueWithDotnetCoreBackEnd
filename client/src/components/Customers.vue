<template>
  <div>
    <div v-for="customer in customers">
      <p>{{ customer.id }}</p>
      <p>{{ customer.firstName }}</p>
      <p>{{ customer.lastName }}</p>
      <p>{{ customer.email}}</p>
    </div>
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
