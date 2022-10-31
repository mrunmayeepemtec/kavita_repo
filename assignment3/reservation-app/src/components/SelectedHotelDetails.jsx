import React from 'react'
import Table from 'react-bootstrap/Table'
import Data from './book-data.json';
import './CSS/post.css'

const SelectedHotelDetails = () => {
  return (
    <div className="container">
      <h1>Selected Hotel Details</h1>
      <Table striped bordered hover size="sm" >
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Address</th>
            <th>Rating</th>
            <th>Email</th>
          </tr>
        </thead>
        <tbody>
          {Data.map((e) => {
            return (
              <tr>
                <td>{e.id}</td>
                <td>{e.name}</td>
                <td>{e.address}</td>
                <td>{e.rating}</td>
                <td>{e.email}</td>
              </tr>
            )
          })}
        </tbody>
      </Table>

    </div>
  )
}

export default SelectedHotelDetails;
