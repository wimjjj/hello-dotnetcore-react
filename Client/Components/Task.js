import React from "react";

export default class Task extends React.Component{
    
    switchDone(e){
        let task = this.props.task;

        task.done ? task.done = false : task.done = true;

        this.props.updateTask(task);
    }

    deleteTask(e){
        let task = this.props.task;

        this.props.deleteTask(task);
    }

    render(){
        let task = this.props.task;

        return (
            <div class="task">
                <h2>{task.title}</h2>
                <button onClick={this.switchDone.bind(this)}>{task.done ? "done" : "not done"}</button>
                <button onClick={this.deleteTask.bind(this)}>delete</button>
            </div>
        )
    }
}