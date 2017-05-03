import React from "react";

import Tasks from "./Tasks";
import TasksApi from "./../Api/TasksApi";
import AddTask from "./AddTask";

export default class Layout extends React.Component {

    constructor(){
        super();

        this.state = {tasks: []};

        this.loadTasks();
    }

    loadTasks(){ TasksApi.getAll().then((tasks) => this.setState({tasks,}))}

    addTask(task) {TasksApi.add(task).then(this.loadTasks.bind(this)) }

    updateTask(task) { TasksApi.update(task).then(this.loadTasks.bind(this)) }

    deleteTask(task) { TasksApi.delete(task).then(this.loadTasks.bind(this))}

    render(){
        let tasks = this.state.tasks;

        return (<div>
                <h1>Tasks</h1>
                <AddTask addTask={this.addTask.bind(this)} />
                <Tasks tasks={tasks} updateTask={this.updateTask.bind(this)} deleteTask={this.deleteTask.bind(this)} />
            </div>); 
    }
}