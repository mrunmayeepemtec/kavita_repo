import React, { useState, Fragment } from 'react';
import {Button, Table} from 'react-bootstrap';
import data from './mock-data.json';
import './CSS/post.css';
import ReadOnlyRow2 from './ReadOnlyRow2';

const ListOfCanceled = () => {
    
    const [posts, setPosts] = useState(data);


  return (
    <div>
        <h1>List of Canceled</h1>

      <div className="container">
        <form>
       <Table striped bordered hover size="sm">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Address</th>
                    <th>Rating</th>
                    <th>Email</th>
                    <th>Actions</th>
                </tr>
            </thead>

            <tbody>
               {posts.map((post) => (
                <Fragment>
                    {
                     ( <ReadOnlyRow2 post={post} 
                    
                    />)
                    }   
                   
                </Fragment>
               ))}
            </tbody>
            </Table>
        </form>
    </div>
    </div>
  )
}

export default ListOfCanceled
