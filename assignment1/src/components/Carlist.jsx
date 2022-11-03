import React from 'react'
import Table from 'react-bootstrap/Table'
import './CSS/car.css'
import { carData } from './carData'

const carlist = (props) => {
  return (
    <div className="container">
    <h1>Car Component</h1>
  <Table striped bordered hover size="sm" >
    <thead>
        <tr>
            <th rowSpan={3}>Model</th>
            <th rowSpan={3}>Company</th>
            <th rowSpan={3}>Price</th>
            <th colSpan={6}>Configuration</th>
        </tr>

        <tr>
            <th rowSpan={2}>Color</th> 
            <th rowSpan={2}>Fuel</th>
            <th rowSpan={2}>Cylinder</th>
            <th rowSpan={2}>Fuel Tank Capacity</th>
            <th colSpan={2}>Mileage</th>
        </tr>

        <tr>
            <th>City</th>
            <th>Highway</th>
        </tr>
    </thead>

    <tbody>
      {carData.map((e) => {
        return(
        <tr>
          <td>{e.model}</td>
          <td>{e.company}</td>
          <td>{e.price}</td>
          <td>{e.configuration.color}</td>
          <td>{e.configuration.fuel}</td>
          <td>{e.configuration.cylinder}</td>
          <td>{e.configuration.fuelTankCapacity}</td>
          <td>{e.configuration.mileage.city}</td>
          <td>{e.configuration.mileage.highway}</td>
        </tr>  
        )
      })} 
    </tbody>
  </Table>
</div>
  )
}

export default carlist
