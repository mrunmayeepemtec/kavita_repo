import React from 'react';
import {Button} from 'react-bootstrap'

const ReadOnlyRow1 = ({post}) => {
  return (

         <tr>
            <td>{post.id}</td>
            <td>{post.name}</td>
            <td>{post.address}</td>
            <td>{post.rating}</td>
            <td>{post.email}</td>
            <td>
                <Button variant="primary" type="button">Booked</Button>
            </td>
        </tr> 

      
  
  )
}

export default ReadOnlyRow1
