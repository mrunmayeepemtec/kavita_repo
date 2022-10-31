import React from 'react';
import {Button} from 'react-bootstrap'

const ReadOnlyRow2 = ({post}) => {
  return (

         <tr>
            <td>{post.id}</td>
            <td>{post.name}</td>
            <td>{post.address}</td>
            <td>{post.rating}</td>
            <td>{post.email}</td>
            <td>
                <Button variant="danger" type="button">Canceled</Button>
            </td>
        </tr> 

      
  
  )
}

export default ReadOnlyRow2