import Axios from "axios";

export default class TasksApi{

    static getAll(){
        return new Promise(function(resolve, reject){
            Axios.get("/api/tasks").then((result) => {
                if(result.status == 200){
                    console.log(result);
                    resolve(result.data);
                } else {
                    console.log(result.status ,result.statusText);
                    reject();
                }
            });
        });
    }

    static add(task){
        return new Promise(function(resolve, reject){
            Axios.post("api/tasks", task).then((result) => {
                if(result.status == 201){
                    console.log(result);
                    resolve();
                }else{
                    console.log(result.status ,result.statusText);
                    reject();
                }
            }); 
        })
    }

    static update(task){
        return new Promise(function(resolve, reject){
            Axios.post("api/tasks/" + task.id, task).then((result) => {
                if(result.status == 200){
                    console.log(result);
                    resolve();
                }else{
                    console.log(result.status ,result.statusText);
                    reject();
                }
            });
        });
    }

    static delete(task){
        return new Promise(function(resolve, reject){
            Axios.post("api/tasks/delete/" + task.id).then((result) => {
                if(result.status == 204){
                    console.log(result);
                    resolve();
                }else{
                    console.log(result.status ,result.statusText);
                    reject();
                }
            });
        });
    }

    static getLabels(){
        return new Promise(function(resolve, reject){
            Axios.get("/api/labels").then((result) => {
                if(result.status == 200){
                    console.log(result);
                    resolve(result.data);
                } else {
                    console.log(result.status ,result.statusText);
                    reject();
                }
            });
        });
    }
}