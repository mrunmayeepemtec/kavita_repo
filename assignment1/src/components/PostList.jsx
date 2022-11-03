import React from 'react'
import Table from 'react-bootstrap/Table'
import Data from './mock-data.json';
import './CSS/post.css'
import Post from './Post'

const PostList = () => {

  return (
    <div className="container">
      <h1>Post Component</h1>
  <Table striped bordered hover size="sm" >
    <thead>
        <tr>
            <th>UserId</th>
            <th>ID</th>
            <th>Title</th>
            <th>Body</th>
        </tr>
    </thead>

    <tbody>
      {Data.map((e) => {
        return(
        <tr>
          <td>{e.userId}</td>
          <td>{e.id}</td>
          <td>{e.title}</td>
          <td>{e.body}</td>
        </tr>  
        )
      })} 
    </tbody>
  </Table>

  <Post />
</div>
  )
}

export default PostList
