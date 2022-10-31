import React, { useState, Fragment } from 'react';
import {Table} from 'react-bootstrap';
import data from './mock-data.json';
import './CSS/post.css';
import ReadOnlyRow3 from './ReadOnlyRow3';

const MarkBooking = () => {
    const [posts, setPosts] = useState(data);
  return (
    <div>
        <h1>Marked Bookings</h1>

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
                     ( <ReadOnlyRow3 post={post} 
                    
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

export default MarkBooking
