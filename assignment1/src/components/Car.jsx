import React from 'react'
import Table from 'react-bootstrap/Table'
import './CSS/car.css'

const Car = () => {
    const car = {
        model: 'i20',
        company: 'Hyundai',
        price: 20,
        configuration: {
            color: 'gray',
            fuel: 'petrol',
            cylinder: 4,
            fuelTankCapacity: 37,
            mileage: {
                city: 14,
                highway: 20,
            },
        },
        features: ['touch screen', 'bluetooth', 'alloy wheels', 'power steering'],
    }

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
            <tr>
                <td>{car.model}</td>
                <td>{car.company}</td>
                <td>{car.price}</td>
                <td>{car.configuration.color}</td>
                <td>{car.configuration.fuel}</td>
                <td>{car.configuration.cylinder}</td>
                <td>{car.configuration.fuelTankCapacity}</td>
                <td>{car.configuration.mileage.city}</td>
                <td>{car.configuration.mileage.highway}</td>
            </tr>
        </tbody>
      </Table>
    </div>
  )
}

export default Car
