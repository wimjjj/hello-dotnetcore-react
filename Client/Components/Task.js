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
            <div class={task.done ? "task-done" : "task-not-done"}>
                <h2>{task.title}</h2>
                <button onClick={this.switchDone.bind(this)} class="button">{task.done ? "done" : "not done"}</button>
                <button onClick={this.deleteTask.bind(this)} class="button button-danger">delete</button>
            </div>
        )
    }
}