import React from 'react';
import Data from './mock-data.json';

const Post = ({userId, id, title, body}) => {
  return (
    <div>
        <h1>PostList Components</h1>
        {Data.map((e) => {
        return(
        <ul>
          <li>UserId:- {e.userId}</li>
          <li>ID:- {e.id}</li>
          <li>Title:- {e.title}</li>
          <li>Body:- {e.body}</li>
        </ul>
        )
        })}
      
    </div>
  )
}

export default Post
