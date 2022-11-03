import React from 'react';
import {Button} from 'react-bootstrap'

const ReadOnlyRow = ({post, handleEditClick, handleDeleteClick}) => {
  return (

         <tr>
            <td>{post.userId}</td>
            <td>{post.id}</td>
            <td>{post.title}</td>
            <td>{post.body}</td>
            <td>
                <Button variant="primary" type="button" onClick={(e) => handleEditClick(e, post)}>Update</Button>
                <Button variant="danger" type="button" onClick={(e) => handleDeleteClick(e, post)}>Delete</Button>
            </td>
        </tr> 

      
  
  )
}

export default ReadOnlyRow
